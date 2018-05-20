using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace QuanLyKhachSan
{
    class KhachHang
    {
        private string phong;
        private string maKH;
        private string tenKH;
        private string loaiKH;
        private string cmndKH;
        private string diaChi;

        public string MaKhachHang
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
            }
        }

        public string TenKhachHang
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }

        public string LoaiKhach
        {
            get
            {
                return loaiKH;
            }

            set
            {
                loaiKH = value;
            }
        }

        public string CMND
        {
            get
            {
                return cmndKH;
            }

            set
            {
                cmndKH = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string Phong
        {
            get
            {
                return phong;
            }

            set
            {
                phong = value;
            }
        }


        //contructor: phòng, mã, tên, loại, cmnd, địa chỉ.
        public KhachHang(string phong, string ma, string ten, string loai, string cmnd, string diachi)
        {
            this.phong = phong;
            maKH = ma;
            tenKH = ten;
            loaiKH = loai;
            cmndKH = cmnd;
            diaChi = diachi;
        }
        
    }
}
