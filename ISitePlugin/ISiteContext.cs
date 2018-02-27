﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace SitePlugin
{
    public interface ISiteContext
    {
        /// <summary>
        /// 
        /// </summary>
        Guid Guid { get; }
        string DisplayName { get; }
        IOptionsTabPage TabPanel { get; }
        void SaveOptions(string dir, IIo io);
        void LoadOptions(string dir, IIo io);        
        ICommentProvider CreateCommentProvider();
        /// <summary>
        /// inputがこのサイトの入力値に適合しているか
        /// 形式が正しいかを判定するだけで、実際に存在するかは関知しない
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool IsValidInput(string input);
        UserControl GetCommentPostPanel(ICommentProvider commentProvider);
    }
}

