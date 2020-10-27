using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string[] urls = {
        "https://nghesiviet.vn/storage/files/7/phuongly/phuong-ly.jpg",
        "https://cdn.24h.com.vn/upload/4-2018/images/2018-12-14/Thu-ngay-nhung-goi-y-ve-toc-va-da-cua-Phuong-Ly-cho-mua-le-hoi-an-tuong-1-1544771307-522-width660height880.jpg",
        "https://www.hellolamode.com/wp-content/uploads/2018/06/a-6.jpg",
        "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcThrvMDaftX1o4OgWj-pGwwx6fzaTWb9-zyTA&usqp=CAU",
        "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSZ8aogCck8Jap9fZdHNLbFqy2xlJX1KHRgcw&usqp=CAU",
        "https://s1.img.yan.vn/YanNews/2167221/201610/20161023-070432-1y4a0094-copy_600x900.jpg",
        "https://vcdn1-ione.vnecdn.net/2018/10/15/hot-girl-phuong-ly-10-8232-1539591271.jpg?w=460&h=0&q=100&dpr=1&fit=crop&s=oorVyvXlRlavQOO6AogBSA",
        "https://i.vietgiaitri.com/2019/4/19/thoat-nong-em-gai-phuong-linh-phuong-ly-tu-tin-bien-hoa-tu-cong--1eb72c.jpg",
        "https://kenh14cdn.com/thumb_w/660/2019/1/16/hoatran-7198-15476571059471523863510.jpg",
        "https://cdn.pose.com.vn/assets/2019/02/27/may_lily_47689998_2003041526662308_4356240748385774162_n.jpg"};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ran = new Random().Next(0, 10);
            pictureBox1.Load(urls[ran]);
        }
    }
}
