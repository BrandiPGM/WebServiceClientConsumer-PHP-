using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceClientConsumer
{

    public class Meteo
    {
        public City_Info city_info { get; set; }
        public Forecast_Info forecast_info { get; set; }
        public Current_Condition current_condition { get; set; }
        public Fcst_Day_0 fcst_day_0 { get; set; }
        public Fcst_Day_1 fcst_day_1 { get; set; }
        public Fcst_Day_2 fcst_day_2 { get; set; }
        public Fcst_Day_3 fcst_day_3 { get; set; }
        public Fcst_Day_4 fcst_day_4 { get; set; }
    }

    public class City_Info
    {
        public string name { get; set; }
        public string country { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string elevation { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
    }

    public class Forecast_Info
    {
        public object latitude { get; set; }
        public object longitude { get; set; }
        public string elevation { get; set; }
    }

    public class Current_Condition
    {
        public string date { get; set; }
        public string hour { get; set; }
        public int tmp { get; set; }
        public int wnd_spd { get; set; }
        public int wnd_gust { get; set; }
        public string wnd_dir { get; set; }
        public float pressure { get; set; }
        public int humidity { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
    }

    public class Fcst_Day_0
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public Hourly_Data hourly_data { get; set; }
    }

    public class Hourly_Data
    {
        public _0H00 _0H00 { get; set; }
        public _1H00 _1H00 { get; set; }
        public _2H00 _2H00 { get; set; }
        public _3H00 _3H00 { get; set; }
        public _4H00 _4H00 { get; set; }
        public _5H00 _5H00 { get; set; }
        public _6H00 _6H00 { get; set; }
        public _7H00 _7H00 { get; set; }
        public _8H00 _8H00 { get; set; }
        public _9H00 _9H00 { get; set; }
        public _10H00 _10H00 { get; set; }
        public _11H00 _11H00 { get; set; }
        public _12H00 _12H00 { get; set; }
        public _13H00 _13H00 { get; set; }
        public _14H00 _14H00 { get; set; }
        public _15H00 _15H00 { get; set; }
        public _16H00 _16H00 { get; set; }
        public _17H00 _17H00 { get; set; }
        public _18H00 _18H00 { get; set; }
        public _19H00 _19H00 { get; set; }
        public _20H00 _20H00 { get; set; }
        public _21H00 _21H00 { get; set; }
        public _22H00 _22H00 { get; set; }
        public _23H00 _23H00 { get; set; }
    }

    public class _0H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _1H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _2H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _3H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _4H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _5H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _6H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _7H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _8H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _9H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _10H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _11H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _12H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _13H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _14H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _15H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _16H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _17H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _18H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _19H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _20H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _21H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _22H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _23H00
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class Fcst_Day_1
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public Hourly_Data1 hourly_data { get; set; }
    }

    public class Hourly_Data1
    {
        public _0H001 _0H00 { get; set; }
        public _1H001 _1H00 { get; set; }
        public _2H001 _2H00 { get; set; }
        public _3H001 _3H00 { get; set; }
        public _4H001 _4H00 { get; set; }
        public _5H001 _5H00 { get; set; }
        public _6H001 _6H00 { get; set; }
        public _7H001 _7H00 { get; set; }
        public _8H001 _8H00 { get; set; }
        public _9H001 _9H00 { get; set; }
        public _10H001 _10H00 { get; set; }
        public _11H001 _11H00 { get; set; }
        public _12H001 _12H00 { get; set; }
        public _13H001 _13H00 { get; set; }
        public _14H001 _14H00 { get; set; }
        public _15H001 _15H00 { get; set; }
        public _16H001 _16H00 { get; set; }
        public _17H001 _17H00 { get; set; }
        public _18H001 _18H00 { get; set; }
        public _19H001 _19H00 { get; set; }
        public _20H001 _20H00 { get; set; }
        public _21H001 _21H00 { get; set; }
        public _22H001 _22H00 { get; set; }
        public _23H001 _23H00 { get; set; }
    }

    public class _0H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _1H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _2H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _3H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _4H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _5H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _6H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _7H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _8H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _9H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _10H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _11H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _12H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _13H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _14H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _15H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _16H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _17H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _18H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _19H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _20H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _21H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _22H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _23H001
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class Fcst_Day_2
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public Hourly_Data2 hourly_data { get; set; }
    }

    public class Hourly_Data2
    {
        public _0H002 _0H00 { get; set; }
        public _1H002 _1H00 { get; set; }
        public _2H002 _2H00 { get; set; }
        public _3H002 _3H00 { get; set; }
        public _4H002 _4H00 { get; set; }
        public _5H002 _5H00 { get; set; }
        public _6H002 _6H00 { get; set; }
        public _7H002 _7H00 { get; set; }
        public _8H002 _8H00 { get; set; }
        public _9H002 _9H00 { get; set; }
        public _10H002 _10H00 { get; set; }
        public _11H002 _11H00 { get; set; }
        public _12H002 _12H00 { get; set; }
        public _13H002 _13H00 { get; set; }
        public _14H002 _14H00 { get; set; }
        public _15H002 _15H00 { get; set; }
        public _16H002 _16H00 { get; set; }
        public _17H002 _17H00 { get; set; }
        public _18H002 _18H00 { get; set; }
        public _19H002 _19H00 { get; set; }
        public _20H002 _20H00 { get; set; }
        public _21H002 _21H00 { get; set; }
        public _22H002 _22H00 { get; set; }
        public _23H002 _23H00 { get; set; }
    }

    public class _0H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _1H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _2H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _3H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _4H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _5H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _6H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _7H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _8H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _9H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _10H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _11H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _12H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _13H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _14H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _15H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _16H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _17H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _18H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _19H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _20H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _21H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _22H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _23H002
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class Fcst_Day_3
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public Hourly_Data3 hourly_data { get; set; }
    }

    public class Hourly_Data3
    {
        public _0H003 _0H00 { get; set; }
        public _1H003 _1H00 { get; set; }
        public _2H003 _2H00 { get; set; }
        public _3H003 _3H00 { get; set; }
        public _4H003 _4H00 { get; set; }
        public _5H003 _5H00 { get; set; }
        public _6H003 _6H00 { get; set; }
        public _7H003 _7H00 { get; set; }
        public _8H003 _8H00 { get; set; }
        public _9H003 _9H00 { get; set; }
        public _10H003 _10H00 { get; set; }
        public _11H003 _11H00 { get; set; }
        public _12H003 _12H00 { get; set; }
        public _13H003 _13H00 { get; set; }
        public _14H003 _14H00 { get; set; }
        public _15H003 _15H00 { get; set; }
        public _16H003 _16H00 { get; set; }
        public _17H003 _17H00 { get; set; }
        public _18H003 _18H00 { get; set; }
        public _19H003 _19H00 { get; set; }
        public _20H003 _20H00 { get; set; }
        public _21H003 _21H00 { get; set; }
        public _22H003 _22H00 { get; set; }
        public _23H003 _23H00 { get; set; }
    }

    public class _0H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _1H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _2H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _3H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _4H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _5H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _6H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _7H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _8H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _9H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _10H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _11H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _12H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _13H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _14H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _15H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _16H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _17H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _18H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _19H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _20H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _21H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _22H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _23H003
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class Fcst_Day_4
    {
        public string date { get; set; }
        public string day_short { get; set; }
        public string day_long { get; set; }
        public int tmin { get; set; }
        public int tmax { get; set; }
        public string condition { get; set; }
        public string condition_key { get; set; }
        public string icon { get; set; }
        public string icon_big { get; set; }
        public Hourly_Data4 hourly_data { get; set; }
    }

    public class Hourly_Data4
    {
        public _0H004 _0H00 { get; set; }
        public _1H004 _1H00 { get; set; }
        public _2H004 _2H00 { get; set; }
        public _3H004 _3H00 { get; set; }
        public _4H004 _4H00 { get; set; }
        public _5H004 _5H00 { get; set; }
        public _6H004 _6H00 { get; set; }
        public _7H004 _7H00 { get; set; }
        public _8H004 _8H00 { get; set; }
        public _9H004 _9H00 { get; set; }
        public _10H004 _10H00 { get; set; }
        public _11H004 _11H00 { get; set; }
        public _12H004 _12H00 { get; set; }
        public _13H004 _13H00 { get; set; }
        public _14H004 _14H00 { get; set; }
        public _15H004 _15H00 { get; set; }
        public _16H004 _16H00 { get; set; }
        public _17H004 _17H00 { get; set; }
        public _18H004 _18H00 { get; set; }
        public _19H004 _19H00 { get; set; }
        public _20H004 _20H00 { get; set; }
        public _21H004 _21H00 { get; set; }
        public _22H004 _22H00 { get; set; }
        public _23H004 _23H00 { get; set; }
    }

    public class _0H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _1H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _2H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _3H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _4H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _5H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _6H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _7H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _8H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _9H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _10H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _11H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _12H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _13H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _14H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _15H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _16H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _17H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _18H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _19H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public int APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _20H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _21H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public int TMP2m { get; set; }
        public float DPT2m { get; set; }
        public int WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _22H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public int DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public float PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

    public class _23H004
    {
        public string ICON { get; set; }
        public string CONDITION { get; set; }
        public string CONDITION_KEY { get; set; }
        public float TMP2m { get; set; }
        public float DPT2m { get; set; }
        public float WNDCHILL2m { get; set; }
        public object HUMIDEX { get; set; }
        public int RH2m { get; set; }
        public int PRMSL { get; set; }
        public float APCPsfc { get; set; }
        public int WNDSPD10m { get; set; }
        public int WNDGUST10m { get; set; }
        public int WNDDIR10m { get; set; }
        public string WNDDIRCARD10 { get; set; }
        public int ISSNOW { get; set; }
        public string HCDC { get; set; }
        public string MCDC { get; set; }
        public string LCDC { get; set; }
        public int HGT0C { get; set; }
        public int KINDEX { get; set; }
        public string CAPE180_0 { get; set; }
        public int CIN180_0 { get; set; }
    }

}
