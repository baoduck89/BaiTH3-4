using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTH3_4.TH3
{
    class Time
    {
        private int gio, phut, giay;

        public Time()
        {
            gio = 0;
            phut = 0;
            giay = 0;
        }

        public Time(int gio, int phut, int giay)
        {
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
        }

        public int Gio
        {
            get
            {
                return gio;
            }
            set
            {
                gio = value;
            }
        }

        public int Phut
        {
            get
            {
                return phut;
            }
            set
            {
                phut = value;
            }
        }

        public int Giay
        {
            get
            {
                return giay;
            }
            set
            {
                giay = value;
            }
        }

        public void Hien()
        {
            Console.WriteLine("{0}:{1}:{2}", gio, phut, giay);
        }

        public int normalize(int gio, int phut, int giay)
        {
            phut = giay / 60;
            giay = giay % 60;
            gio = phut / 60;
            phut = phut % 60;
            gio = gio % 24;

            return gio; return phut; return giay;
        }

        public Time advance(int gio, int phut, int giay)
        {
            Time t = new Time();
            t.gio = this.gio + gio;
            t.phut = this.phut + phut;
            t.giay = this.giay + giay;

            t.phut = giay / 60;
            t.giay = giay % 60;
            t.gio = phut / 60;
            t.phut = phut % 60;
            t.gio = gio % 24;
            return t;
        }
    }
}

