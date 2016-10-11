﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Virtion.Util;
using WeChat;

namespace Virtion.WeChat
{
    public class WXApi
    {
        public static string QrCodeUuidUrl = "http://login.weixin.qq.com/jslogin?appid=wx782c26e4c19acffb&redirect_uri=http%3A%2F%2Fwx.qq.com%2Fcgi-bin%2Fmmwebwx-bin%2Fwebwxnewloginpage&fun=new&lang=zh_CN&_=" + Time.Now();
        public static string QrCodeImageUrl = "http://login.weixin.qq.com/qrcode/";

        public static string LoginUrl = "http://wx.qq.com/cgi-bin/mmwebwx-bin/login";
        public static string GetInitUrl = "http://wx.qq.com/cgi-bin/mmwebwx-bin/webwxinit";

        public static string SyncMsgUrl = "http://wx.qq.com/cgi-bin/mmwebwx-bin/webwxsync?";

        public static string GetDetailUrl = "http://wx.qq.com/cgi-bin/mmwebwx-bin/webwxbatchgetcontact?";

        public static string GetContactUrl = "http://wx.qq.com/cgi-bin/mmwebwx-bin/webwxgetcontact?";

        public static string DeleteMenberUrl = "http://wx.qq.com/cgi-bin/mmwebwx-bin/webwxupdatechatroom?fun=delmember";

        public static string SendMessageUrl = "http://wx.qq.com/cgi-bin/mmwebwx-bin/webwxsendmsg";

        public static string SyncCheckUrl = "http://webpush.weixin.qq.com/cgi-bin/mmwebwx-bin/synccheck";

        public static string StatusNotifyUrl = "http://wx.qq.com/cgi-bin/mmwebwx-bin/webwxstatusnotify";
    
    }
}