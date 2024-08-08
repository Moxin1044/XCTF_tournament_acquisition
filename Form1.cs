using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO.Compression;
using System.IO;

namespace XCTF赛事列表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // 目标URL
            string url = "https://adworld.xctf.org.cn/api/event/release_event/list/?page=1&page_size=1000&search=&isSearch=false&event_status=&event_type=";

            // 请求头
            var headers = new HttpClient();
            headers.DefaultRequestHeaders.Add("sec-ch-ua", "\"Not)A;Brand\";v=\"99\", \"Google Chrome\";v=\"127\", \"Chromium\";v=\"127\"");
            headers.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
            headers.DefaultRequestHeaders.Add("Accept-Language", "zh-CN");
            headers.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
            headers.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/127.0.0.0 Safari/537.36");
            headers.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"macOS\"");
            headers.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");
            headers.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
            headers.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
            headers.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br, zstd");
            headers.DefaultRequestHeaders.Add("Connection", "keep-alive");
            headers.DefaultRequestHeaders.Add("Host", "adworld.xctf.org.cn");

            // 发送GET请求
            HttpResponseMessage response = await headers.GetAsync(url);

            // 检查响应状态码
            if (response.IsSuccessStatusCode)
            {
                // 解压缩响应内容
                Stream responseStream = await response.Content.ReadAsStreamAsync();
                using (var decompressedStream = new GZipStream(responseStream, CompressionMode.Decompress))
                using (var reader = new StreamReader(decompressedStream))
                {
                    string responseBody = await reader.ReadToEndAsync();
                    JObject data = JObject.Parse(responseBody);
                    JArray games = (JArray)data["data"]["rows"];
                    foreach (var item in games)
                    {
                        string releaseName = item["release_name"].ToString();
                        string releaseSponsor = item["release_sponsor"].ToString();
                        string competitionStartTime = item["competition_start_time"].ToString();
                        string competitionEndTime = item["competition_end_time"].ToString();
                        dataGridView1.Rows.Add(releaseName, releaseSponsor, competitionStartTime, competitionEndTime);
                        // MessageBox.Show($"竞赛名称：{releaseName} \n主办方：{releaseSponsor} \n比赛开始时间：{competitionStartTime} \n比赛结束时间：{competitionEndTime}");
                    }
                }
            }
            else
            {
                // 打印错误信息
                string errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"请求失败，状态码为: {response.StatusCode}\n{errorMessage}");
            }
        }
    }
}
