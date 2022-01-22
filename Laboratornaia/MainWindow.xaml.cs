using DocumentFormat.OpenXml.EMMA;
using Microsoft.Win32;
using OfficeOpenXml;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Laboratornaia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<RecordingThreat> allRecordingThreat;
        private IPagedList<RecordingThreat> recordingThreatOnPage;
        private int numberOfPage = 1;

        public MainWindow()
        {
            InitializeComponent();
            if (Metods.CheckFile())
            {
                allRecordingThreat = ReadExcelFile();
                recordingThreatOnPage = GetPagedList();
                mainTable.ItemsSource = recordingThreatOnPage;
                pageNumberText.Content = $"Page {numberOfPage}/{recordingThreatOnPage.PageCount}";
            }
        }

        private void Download_Button(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(Metods.FileName))
            {
                Metods.GetFile();
                allRecordingThreat = ReadExcelFile();
                recordingThreatOnPage = GetPagedList();
                mainTable.ItemsSource = recordingThreatOnPage;
                pageNumberText.Content = $"Page {numberOfPage}/{ recordingThreatOnPage.PageCount}";
            }
            else
            {
                MessageBox.Show("На вашем утройстве уже есть файл");
            }
        }

        private List<RecordingThreat> ReadExcelFile()
        {
            List<RecordingThreat> threats = new List<RecordingThreat>();
            FileInfo existingFile = new FileInfo(Metods.FileName);
            using (ExcelPackage excelPackage = new ExcelPackage(existingFile))
            {
                foreach (ExcelWorksheet worksheet in excelPackage.Workbook.Worksheets)
                {
                    for (int i = worksheet.Dimension.Start.Row + 2; i <= worksheet.Dimension.End.Row; i++)
                    {
                        int j = 1;
                        for (int k = 0; k < 8; k++)
                        {
                            if (worksheet.Cells[i, j + k].Value == null)
                            {
                                worksheet.Cells[i, j + k].Value = "";
                            }
                        }
                        RecordingThreat RecordingThreat = new RecordingThreat(worksheet.Cells[i, j].Value.ToString(), worksheet.Cells[i, j + 1].Value.ToString(),
                                worksheet.Cells[i, j + 2].Value.ToString(), worksheet.Cells[i, j + 3].Value.ToString(),
                                worksheet.Cells[i, j + 4].Value.ToString(), worksheet.Cells[i, j + 5].Value.ToString(),
                                worksheet.Cells[i, j + 6].Value.ToString(), worksheet.Cells[i, j + 7].Value.ToString());

                        threats.Add(RecordingThreat);
                    }
                }
            }
            return threats;
        }

        private IPagedList<RecordingThreat> GetPagedList(int numberOfPage = 1, int pageSize = 15)
        {
            return allRecordingThreat.ToPagedList(numberOfPage, pageSize);
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            if (row == null)
            {
                return;
            }
            ThreatInformation infoWindow = new ThreatInformation();
            infoWindow.Show();
            infoWindow.ShowInfo(recordingThreatOnPage[row.GetIndex()]);
        }

        private void UpdateFileButton_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(Metods.FileName))
            {
                var temp = allRecordingThreat;
                Metods.UpdateFile();
                allRecordingThreat = ReadExcelFile();
                UpdateTable updateWindow = new UpdateTable();
                updateWindow.UpdatedInfo(allRecordingThreat, temp);
            }
            else
            {
                MessageBox.Show("Данные не были загружены.");
            }
        }

        private void SavingButton_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(Metods.FileName))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel file |.xlsx;";
                saveFileDialog.DefaultExt = "xlsx";
                if (saveFileDialog.ShowDialog() == true)
                {
                    byte[] bytes = File.ReadAllBytes(Metods.FileName);
                    File.WriteAllBytes(saveFileDialog.FileName, bytes);
                }
            }
            else
            {
                MessageBox.Show("Данные ещё не были загружены.");
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (recordingThreatOnPage != null)
            {
                if (recordingThreatOnPage.HasPreviousPage)
                {
                    recordingThreatOnPage = GetPagedList(--numberOfPage);
                    mainTable.ItemsSource = recordingThreatOnPage;
                    pageNumberText.Content = $"Page {numberOfPage}/{ recordingThreatOnPage.PageCount}";
                }
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (recordingThreatOnPage != null)
            {
                if (recordingThreatOnPage.HasNextPage)
                {
                    recordingThreatOnPage = GetPagedList(++numberOfPage);
                    mainTable.ItemsSource = recordingThreatOnPage;
                    pageNumberText.Content = $"Page {numberOfPage}/{ recordingThreatOnPage.PageCount}";
                }
            }
        }
    }
}
