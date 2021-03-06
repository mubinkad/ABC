﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ButtonTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ButtonTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("8a2d8396-17a8-44d6-a5d3-52edfe04e262")]
    public partial class ButtonTestRepository : RepoGenBaseFolder
    {
        static ButtonTestRepository instance = new ButtonTestRepository();
        ButtonTestRepositoryFolders.RanorexSiteAppFolder _ranorexsite;
        ButtonTestRepositoryFolders.RxMainFrameAppFolder _rxmainframe;
        ButtonTestRepositoryFolders.UntitledNotepadAppFolder _untitlednotepad;
        ButtonTestRepositoryFolders.JustWebObjFolder _justwebobj;
        ButtonTestRepositoryFolders.IEBRowserAppFolder _iebrowser;
        ButtonTestRepositoryFolders.ExplorerAppFolder _explorer;
        ButtonTestRepositoryFolders.CalculatorAppFolder _calculator;
        ButtonTestRepositoryFolders.GoogleAppFolder _google;
        ButtonTestRepositoryFolders.SlackTestingToolsAppFolder _slacktestingtools;

        /// <summary>
        /// Gets the singleton class instance representing the ButtonTestRepository element repository.
        /// </summary>
        [RepositoryFolder("8a2d8396-17a8-44d6-a5d3-52edfe04e262")]
        public static ButtonTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ButtonTestRepository() 
            : base("ButtonTestRepository", "/", null, 0, false, "8a2d8396-17a8-44d6-a5d3-52edfe04e262", ".\\RepositoryImages\\ButtonTestRepository8a2d8396.rximgres")
        {
            _ranorexsite = new ButtonTestRepositoryFolders.RanorexSiteAppFolder(this);
            _rxmainframe = new ButtonTestRepositoryFolders.RxMainFrameAppFolder(this);
            _untitlednotepad = new ButtonTestRepositoryFolders.UntitledNotepadAppFolder(this);
            _justwebobj = new ButtonTestRepositoryFolders.JustWebObjFolder(this);
            _iebrowser = new ButtonTestRepositoryFolders.IEBRowserAppFolder(this);
            _explorer = new ButtonTestRepositoryFolders.ExplorerAppFolder(this);
            _calculator = new ButtonTestRepositoryFolders.CalculatorAppFolder(this);
            _google = new ButtonTestRepositoryFolders.GoogleAppFolder(this);
            _slacktestingtools = new ButtonTestRepositoryFolders.SlackTestingToolsAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("8a2d8396-17a8-44d6-a5d3-52edfe04e262")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RanorexSite folder.
        /// </summary>
        [RepositoryFolder("c4e1bed3-c24c-49e5-9ff8-cdea1efd22fe")]
        public virtual ButtonTestRepositoryFolders.RanorexSiteAppFolder RanorexSite
        {
            get { return _ranorexsite; }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("ea9f5db6-2e58-48a6-8437-0f0615e29f8b")]
        public virtual ButtonTestRepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }

        /// <summary>
        /// The UntitledNotepad folder.
        /// </summary>
        [RepositoryFolder("a203cefb-19f8-4791-9a71-2b01e11da8f3")]
        public virtual ButtonTestRepositoryFolders.UntitledNotepadAppFolder UntitledNotepad
        {
            get { return _untitlednotepad; }
        }

        /// <summary>
        /// The JustWebObj folder.
        /// </summary>
        [RepositoryFolder("e624383c-a8bc-4b2d-b7e5-dfd9b5d90807")]
        public virtual ButtonTestRepositoryFolders.JustWebObjFolder JustWebObj
        {
            get { return _justwebobj; }
        }

        /// <summary>
        /// The IEBRowser folder.
        /// </summary>
        [RepositoryFolder("1cfbe149-f6e7-445f-a2b9-b441ba46b6d7")]
        public virtual ButtonTestRepositoryFolders.IEBRowserAppFolder IEBRowser
        {
            get { return _iebrowser; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("5feb7268-eed5-45d3-b6b6-33b5cb60a038")]
        public virtual ButtonTestRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The Calculator folder.
        /// </summary>
        [RepositoryFolder("8ff9e5e5-9ba0-4af4-b504-c10b055792f3")]
        public virtual ButtonTestRepositoryFolders.CalculatorAppFolder Calculator
        {
            get { return _calculator; }
        }

        /// <summary>
        /// The Google folder.
        /// </summary>
        [RepositoryFolder("f8ac0658-bdd0-4616-962d-ddd2de4ff6de")]
        public virtual ButtonTestRepositoryFolders.GoogleAppFolder Google
        {
            get { return _google; }
        }

        /// <summary>
        /// The SlackTestingTools folder.
        /// </summary>
        [RepositoryFolder("f47edb4b-85db-4ecc-9eee-12850d1fd2b7")]
        public virtual ButtonTestRepositoryFolders.SlackTestingToolsAppFolder SlackTestingTools
        {
            get { return _slacktestingtools; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class ButtonTestRepositoryFolders
    {
        /// <summary>
        /// The RanorexSiteAppFolder folder.
        /// </summary>
        [RepositoryFolder("c4e1bed3-c24c-49e5-9ff8-cdea1efd22fe")]
        public partial class RanorexSiteAppFolder : RepoGenBaseFolder
        {
            ButtonTestRepositoryFolders.SubMenuFolder _submenu;
            RepoItemInfo _creatingaranorexsnapshotInfo;
            RepoItemInfo _tracelogcreationInfo;

            /// <summary>
            /// Creates a new RanorexSite  folder.
            /// </summary>
            public RanorexSiteAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RanorexSite", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "c4e1bed3-c24c-49e5-9ff8-cdea1efd22fe", "")
            {
                _submenu = new ButtonTestRepositoryFolders.SubMenuFolder(this);
                _creatingaranorexsnapshotInfo = new RepoItemInfo(this, "CreatingARanorexSnapshot", ".//div[#'et_builder_outer_content']/div/div/div[1]//h1[@innertext>'Creating a Ranorex snapsh']", 5000, null, "c9b4a18b-4727-434f-b02c-ec49cc490919");
                _tracelogcreationInfo = new RepoItemInfo(this, "TraceLogCreation", ".//div[#'et_builder_outer_content']/div/div/div[1]//ul/li[1]/a[@innertext='Trace log creation']", 30000, null, "db862a47-e586-4996-964a-2ec6ed54db0f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c4e1bed3-c24c-49e5-9ff8-cdea1efd22fe")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c4e1bed3-c24c-49e5-9ff8-cdea1efd22fe")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The CreatingARanorexSnapshot item.
            /// </summary>
            [RepositoryItem("c9b4a18b-4727-434f-b02c-ec49cc490919")]
            public virtual Ranorex.H1Tag CreatingARanorexSnapshot
            {
                get
                {
                    return _creatingaranorexsnapshotInfo.CreateAdapter<Ranorex.H1Tag>(true);
                }
            }

            /// <summary>
            /// The CreatingARanorexSnapshot item info.
            /// </summary>
            [RepositoryItemInfo("c9b4a18b-4727-434f-b02c-ec49cc490919")]
            public virtual RepoItemInfo CreatingARanorexSnapshotInfo
            {
                get
                {
                    return _creatingaranorexsnapshotInfo;
                }
            }

            /// <summary>
            /// The TraceLogCreation item.
            /// </summary>
            [RepositoryItem("db862a47-e586-4996-964a-2ec6ed54db0f")]
            public virtual Ranorex.ATag TraceLogCreation
            {
                get
                {
                    return _tracelogcreationInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The TraceLogCreation item info.
            /// </summary>
            [RepositoryItemInfo("db862a47-e586-4996-964a-2ec6ed54db0f")]
            public virtual RepoItemInfo TraceLogCreationInfo
            {
                get
                {
                    return _tracelogcreationInfo;
                }
            }

            /// <summary>
            /// The SubMenu folder.
            /// </summary>
            [RepositoryFolder("a2a61f96-c190-4dff-95e2-175c8b558150")]
            public virtual ButtonTestRepositoryFolders.SubMenuFolder SubMenu
            {
                get { return _submenu; }
            }
        }

        /// <summary>
        /// The SubMenuFolder folder.
        /// </summary>
        [RepositoryFolder("a2a61f96-c190-4dff-95e2-175c8b558150")]
        public partial class SubMenuFolder : RepoGenBaseFolder
        {
            RepoItemInfo _introductionInfo;
            RepoItemInfo _leveragethedataInfo;
            RepoItemInfo _tracelogsInfo;

            /// <summary>
            /// Creates a new SubMenu  folder.
            /// </summary>
            public SubMenuFolder(RepoGenBaseFolder parentFolder) :
                    base("SubMenu", ".//div[#'rx-content']//nav//ul/li[2]/ul/li[8]/ul", parentFolder, 30000, null, false, "a2a61f96-c190-4dff-95e2-175c8b558150", "")
            {
                _introductionInfo = new RepoItemInfo(this, "Introduction", "?/?/a[@innertext='Introduction']", 30000, null, "77618059-f7e0-4ea8-ac58-50b6dbc02f6e");
                _leveragethedataInfo = new RepoItemInfo(this, "LeverageTheData", "?/?/a[@innertext='Leverage the data']", 30000, null, "8d5b8c00-f919-4411-8b37-4a52f18e1774");
                _tracelogsInfo = new RepoItemInfo(this, "TraceLogs", "?/?/a[@innertext='Trace logs']", 30000, null, "8f3aba46-d2d8-4bd0-aab3-97d18aee3a4b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a2a61f96-c190-4dff-95e2-175c8b558150")]
            public virtual Ranorex.UlTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.UlTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a2a61f96-c190-4dff-95e2-175c8b558150")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Introduction item.
            /// </summary>
            [RepositoryItem("77618059-f7e0-4ea8-ac58-50b6dbc02f6e")]
            public virtual Ranorex.ATag Introduction
            {
                get
                {
                    return _introductionInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Introduction item info.
            /// </summary>
            [RepositoryItemInfo("77618059-f7e0-4ea8-ac58-50b6dbc02f6e")]
            public virtual RepoItemInfo IntroductionInfo
            {
                get
                {
                    return _introductionInfo;
                }
            }

            /// <summary>
            /// The LeverageTheData item.
            /// </summary>
            [RepositoryItem("8d5b8c00-f919-4411-8b37-4a52f18e1774")]
            public virtual Ranorex.ATag LeverageTheData
            {
                get
                {
                    return _leveragethedataInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LeverageTheData item info.
            /// </summary>
            [RepositoryItemInfo("8d5b8c00-f919-4411-8b37-4a52f18e1774")]
            public virtual RepoItemInfo LeverageTheDataInfo
            {
                get
                {
                    return _leveragethedataInfo;
                }
            }

            /// <summary>
            /// The TraceLogs item.
            /// </summary>
            [RepositoryItem("8f3aba46-d2d8-4bd0-aab3-97d18aee3a4b")]
            public virtual Ranorex.ATag TraceLogs
            {
                get
                {
                    return _tracelogsInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The TraceLogs item info.
            /// </summary>
            [RepositoryItemInfo("8f3aba46-d2d8-4bd0-aab3-97d18aee3a4b")]
            public virtual RepoItemInfo TraceLogsInfo
            {
                get
                {
                    return _tracelogsInfo;
                }
            }
        }

        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("ea9f5db6-2e58-48a6-8437-0f0615e29f8b")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _topleftheadercellInfo;
            RepoItemInfo _datagridview1Info;
            RepoItemInfo _genderrow6Info;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "ea9f5db6-2e58-48a6-8437-0f0615e29f8b", "")
            {
                _topleftheadercellInfo = new RepoItemInfo(this, "TopLeftHeaderCell", "?/?/tabpage[@controlname='RxTabUIElements']/table[@controlname='dataGridView1']/?/?/cell[@accessiblename='Top Left Header Cell']", 30000, null, "fb5a013f-e7cd-4888-aeb7-d742c1e6fe50");
                _datagridview1Info = new RepoItemInfo(this, "DataGridView1", "tabpagelist[@controlname='RxTabcontrol']/?/?/table[@controlname='dataGridView1']", 30000, null, "ffaefb15-1b40-4a8b-b1b4-86e6568fb51e");
                _genderrow6Info = new RepoItemInfo(this, "GenderRow6", "?/?/tabpage[@controlname='RxTabUIElements']/table[@controlname='dataGridView1']/?/?/cell[@accessiblevalue='Male']", 30000, null, "aca46703-183b-4a85-9e30-91ac2edbecc1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ea9f5db6-2e58-48a6-8437-0f0615e29f8b")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ea9f5db6-2e58-48a6-8437-0f0615e29f8b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TopLeftHeaderCell item.
            /// </summary>
            [RepositoryItem("fb5a013f-e7cd-4888-aeb7-d742c1e6fe50")]
            public virtual Ranorex.Cell TopLeftHeaderCell
            {
                get
                {
                    return _topleftheadercellInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The TopLeftHeaderCell item info.
            /// </summary>
            [RepositoryItemInfo("fb5a013f-e7cd-4888-aeb7-d742c1e6fe50")]
            public virtual RepoItemInfo TopLeftHeaderCellInfo
            {
                get
                {
                    return _topleftheadercellInfo;
                }
            }

            /// <summary>
            /// The DataGridView1 item.
            /// </summary>
            [RepositoryItem("ffaefb15-1b40-4a8b-b1b4-86e6568fb51e")]
            public virtual Ranorex.Table DataGridView1
            {
                get
                {
                    return _datagridview1Info.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The DataGridView1 item info.
            /// </summary>
            [RepositoryItemInfo("ffaefb15-1b40-4a8b-b1b4-86e6568fb51e")]
            public virtual RepoItemInfo DataGridView1Info
            {
                get
                {
                    return _datagridview1Info;
                }
            }

            /// <summary>
            /// The GenderRow6 item.
            /// </summary>
            [RepositoryItem("aca46703-183b-4a85-9e30-91ac2edbecc1")]
            public virtual Ranorex.Cell GenderRow6
            {
                get
                {
                    return _genderrow6Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The GenderRow6 item info.
            /// </summary>
            [RepositoryItemInfo("aca46703-183b-4a85-9e30-91ac2edbecc1")]
            public virtual RepoItemInfo GenderRow6Info
            {
                get
                {
                    return _genderrow6Info;
                }
            }
        }

        /// <summary>
        /// The UntitledNotepadAppFolder folder.
        /// </summary>
        [RepositoryFolder("a203cefb-19f8-4791-9a71-2b01e11da8f3")]
        public partial class UntitledNotepadAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text15Info;

            /// <summary>
            /// Creates a new UntitledNotepad  folder.
            /// </summary>
            public UntitledNotepadAppFolder(RepoGenBaseFolder parentFolder) :
                    base("UntitledNotepad", "/form[@title='Untitled - Notepad']", parentFolder, 30000, null, true, "a203cefb-19f8-4791-9a71-2b01e11da8f3", "")
            {
                _text15Info = new RepoItemInfo(this, "Text15", "text[@controlid='15']", 30000, null, "c05c4180-412b-4ce1-b51e-16828b232931");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a203cefb-19f8-4791-9a71-2b01e11da8f3")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a203cefb-19f8-4791-9a71-2b01e11da8f3")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text15 item.
            /// </summary>
            [RepositoryItem("c05c4180-412b-4ce1-b51e-16828b232931")]
            public virtual Ranorex.Text Text15
            {
                get
                {
                    return _text15Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text15 item info.
            /// </summary>
            [RepositoryItemInfo("c05c4180-412b-4ce1-b51e-16828b232931")]
            public virtual RepoItemInfo Text15Info
            {
                get
                {
                    return _text15Info;
                }
            }
        }

        /// <summary>
        /// The JustWebObjFolder folder.
        /// </summary>
        [RepositoryFolder("e624383c-a8bc-4b2d-b7e5-dfd9b5d90807")]
        public partial class JustWebObjFolder : RepoGenBaseFolder
        {
            ButtonTestRepositoryFolders.GoogleGoogleChromeAppFolder _googlegooglechrome;

            /// <summary>
            /// Creates a new JustWebObj  folder.
            /// </summary>
            public JustWebObjFolder(RepoGenBaseFolder parentFolder) :
                    base("JustWebObj", "", parentFolder, 0, null, false, "e624383c-a8bc-4b2d-b7e5-dfd9b5d90807", "")
            {
                _googlegooglechrome = new ButtonTestRepositoryFolders.GoogleGoogleChromeAppFolder(this);
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e624383c-a8bc-4b2d-b7e5-dfd9b5d90807")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The GoogleGoogleChrome folder.
            /// </summary>
            [RepositoryFolder("5ab2aebb-d9f4-4851-b7e0-cade4928f080")]
            public virtual ButtonTestRepositoryFolders.GoogleGoogleChromeAppFolder GoogleGoogleChrome
            {
                get { return _googlegooglechrome; }
            }
        }

        /// <summary>
        /// The GoogleGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("5ab2aebb-d9f4-4851-b7e0-cade4928f080")]
        public partial class GoogleGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text1548522256716Info;
            RepoItemInfo _cachestorageInfo;
            RepoItemInfo _copy_of_cachestorageInfo;

            /// <summary>
            /// Creates a new GoogleGoogleChrome  folder.
            /// </summary>
            public GoogleGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("GoogleGoogleChrome", "/form[@title='Google - Google Chrome']", parentFolder, 30000, null, false, "5ab2aebb-d9f4-4851-b7e0-cade4928f080", "")
            {
                _text1548522256716Info = new RepoItemInfo(this, "Text1548522256716", "element[@controlid='-1799038816']/container[@accessiblerole='Document']//element/element[@accessiblerole='None']/element[2]/element/element[@accessiblerole='None']/element[@accessiblerole='None']/element[1]/?/?/element[@accessiblename>'Select an element in the page']/container[@accessiblerole='PropertyPage']/element[@accessiblename='resources']/element[@accessiblename='resources']/element/element[@accessiblerole='None']/element[2]/element/element[@accessiblerole='None']/element[@accessiblerole='None']/element[2]/?/?/element[@accessiblerole='None']/element/element[@accessiblerole='None']/element[2]/table[@accessiblerole='Table']/row[2]/cell[@accessiblename='1548522256716']/text[@accessiblename='1548522256716']", 30000, null, "72a2b7bc-c8b1-4754-b429-85ad0e2c8282");
                _cachestorageInfo = new RepoItemInfo(this, "CacheStorage", "?/container[@accessiblerole='Document']//element/element[@accessiblerole='None']/element[2]/element/element[@accessiblerole='None']/element[@accessiblerole='None']/element[1]/?/?/element[@accessiblename>'Select an element in the page']/container[@accessiblerole='PropertyPage']/element[@accessiblename='resources']/element[@accessiblename='resources']/element/element[@accessiblerole='None']/element[2]/?/?/element/element[@accessiblerole='None']/element[@accessiblerole='None']/element[@accessiblerole='None']/element[@accessiblerole='None']/element[@accessiblerole='None']/element[2]/element[1]/element[2]/element[2]/text[@accessiblename='Cache Storage']", 30000, null, "2ea7e6af-c2ca-43d1-b402-3e946cc4a157");
                _copy_of_cachestorageInfo = new RepoItemInfo(this, "Copy_of_CacheStorage", "?/container[@accessiblerole='Document']//element/element[@accessiblerole='None']/element[2]/element/element[@accessiblerole='None']/?/?/element[@accessiblerole='None']/?/?/element[@accessiblename>'Select an element in the page']/container[@accessiblerole='PropertyPage']/element[@accessiblename='resources']/element[@accessiblename='resources']/element/element[@accessiblerole='None']/element[1]//tree[@accessiblerole='Outline']/container[1]/treeitem[@accessiblename='   Clear storage']", 30000, null, "0b997727-e5eb-40c7-a5c5-a47b3aab0f6e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5ab2aebb-d9f4-4851-b7e0-cade4928f080")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5ab2aebb-d9f4-4851-b7e0-cade4928f080")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text1548522256716 item.
            /// </summary>
            [RepositoryItem("72a2b7bc-c8b1-4754-b429-85ad0e2c8282")]
            public virtual Ranorex.Text Text1548522256716
            {
                get
                {
                    return _text1548522256716Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1548522256716 item info.
            /// </summary>
            [RepositoryItemInfo("72a2b7bc-c8b1-4754-b429-85ad0e2c8282")]
            public virtual RepoItemInfo Text1548522256716Info
            {
                get
                {
                    return _text1548522256716Info;
                }
            }

            /// <summary>
            /// The CacheStorage item.
            /// </summary>
            [RepositoryItem("2ea7e6af-c2ca-43d1-b402-3e946cc4a157")]
            public virtual Ranorex.Text CacheStorage
            {
                get
                {
                    return _cachestorageInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The CacheStorage item info.
            /// </summary>
            [RepositoryItemInfo("2ea7e6af-c2ca-43d1-b402-3e946cc4a157")]
            public virtual RepoItemInfo CacheStorageInfo
            {
                get
                {
                    return _cachestorageInfo;
                }
            }

            /// <summary>
            /// The Copy_of_CacheStorage item.
            /// </summary>
            [RepositoryItem("0b997727-e5eb-40c7-a5c5-a47b3aab0f6e")]
            public virtual Ranorex.TreeItem Copy_of_CacheStorage
            {
                get
                {
                    return _copy_of_cachestorageInfo.CreateAdapter<Ranorex.TreeItem>(true);
                }
            }

            /// <summary>
            /// The Copy_of_CacheStorage item info.
            /// </summary>
            [RepositoryItemInfo("0b997727-e5eb-40c7-a5c5-a47b3aab0f6e")]
            public virtual RepoItemInfo Copy_of_CacheStorageInfo
            {
                get
                {
                    return _copy_of_cachestorageInfo;
                }
            }
        }

        /// <summary>
        /// The IEBRowserAppFolder folder.
        /// </summary>
        [RepositoryFolder("1cfbe149-f6e7-445f-a2b9-b441ba46b6d7")]
        public partial class IEBRowserAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new IEBRowser  folder.
            /// </summary>
            public IEBRowserAppFolder(RepoGenBaseFolder parentFolder) :
                    base("IEBRowser", "/form[@title>'Google - Internet Explore']", parentFolder, 30000, null, true, "1cfbe149-f6e7-445f-a2b9-b441ba46b6d7", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1cfbe149-f6e7-445f-a2b9-b441ba46b6d7")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1cfbe149-f6e7-445f-a2b9-b441ba46b6d7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("5feb7268-eed5-45d3-b6b6-33b5cb60a038")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _calculatorInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "5feb7268-eed5-45d3-b6b6-33b5cb60a038", "")
            {
                _calculatorInfo = new RepoItemInfo(this, "Calculator", "container[@controlid='40965']//toolbar[@accessiblename='Running applications']/button[@accessiblename='Calculator']", 30000, null, "74187cba-24dc-42d5-b912-7efeb6996055");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5feb7268-eed5-45d3-b6b6-33b5cb60a038")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5feb7268-eed5-45d3-b6b6-33b5cb60a038")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Calculator item.
            /// </summary>
            [RepositoryItem("74187cba-24dc-42d5-b912-7efeb6996055")]
            public virtual Ranorex.Button Calculator
            {
                get
                {
                    return _calculatorInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Calculator item info.
            /// </summary>
            [RepositoryItemInfo("74187cba-24dc-42d5-b912-7efeb6996055")]
            public virtual RepoItemInfo CalculatorInfo
            {
                get
                {
                    return _calculatorInfo;
                }
            }
        }

        /// <summary>
        /// The CalculatorAppFolder folder.
        /// </summary>
        [RepositoryFolder("8ff9e5e5-9ba0-4af4-b504-c10b055792f3")]
        public partial class CalculatorAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _closeInfo;

            /// <summary>
            /// Creates a new Calculator  folder.
            /// </summary>
            public CalculatorAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Calculator", "/winapp[@packagename='Microsoft.WindowsCalculator']", parentFolder, 30000, null, true, "8ff9e5e5-9ba0-4af4-b504-c10b055792f3", "")
            {
                _closeInfo = new RepoItemInfo(this, "Close", "?/?/button[@automationid='Close']", 30000, null, "fa0ba725-01a9-4eed-9a1d-e52b6cd29d97");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("8ff9e5e5-9ba0-4af4-b504-c10b055792f3")]
            public virtual Ranorex.WindowsApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WindowsApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("8ff9e5e5-9ba0-4af4-b504-c10b055792f3")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("fa0ba725-01a9-4eed-9a1d-e52b6cd29d97")]
            public virtual Ranorex.Button Close
            {
                get
                {
                    return _closeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Close item info.
            /// </summary>
            [RepositoryItemInfo("fa0ba725-01a9-4eed-9a1d-e52b6cd29d97")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }
        }

        /// <summary>
        /// The GoogleAppFolder folder.
        /// </summary>
        [RepositoryFolder("f8ac0658-bdd0-4616-962d-ddd2de4ff6de")]
        public partial class GoogleAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _inputtagqInfo;

            /// <summary>
            /// Creates a new Google  folder.
            /// </summary>
            public GoogleAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Google", "/dom[@domain='www.google.com']", parentFolder, 30000, null, false, "f8ac0658-bdd0-4616-962d-ddd2de4ff6de", "")
            {
                _inputtagqInfo = new RepoItemInfo(this, "InputTagQ", ".//form[#'tsf']/div[2]/div/div[1]//input[@title='Search']", 30000, null, "defcd8f8-f326-487d-bef5-cdb1f023f8f3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f8ac0658-bdd0-4616-962d-ddd2de4ff6de")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("f8ac0658-bdd0-4616-962d-ddd2de4ff6de")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The InputTagQ item.
            /// </summary>
            [RepositoryItem("defcd8f8-f326-487d-bef5-cdb1f023f8f3")]
            public virtual Ranorex.InputTag InputTagQ
            {
                get
                {
                    return _inputtagqInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagQ item info.
            /// </summary>
            [RepositoryItemInfo("defcd8f8-f326-487d-bef5-cdb1f023f8f3")]
            public virtual RepoItemInfo InputTagQInfo
            {
                get
                {
                    return _inputtagqInfo;
                }
            }
        }

        /// <summary>
        /// The SlackTestingToolsAppFolder folder.
        /// </summary>
        [RepositoryFolder("f47edb4b-85db-4ecc-9eee-12850d1fd2b7")]
        public partial class SlackTestingToolsAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new SlackTestingTools  folder.
            /// </summary>
            public SlackTestingToolsAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SlackTestingTools", "/form[@title='Slack - Testing Tools']", parentFolder, 30000, null, true, "f47edb4b-85db-4ecc-9eee-12850d1fd2b7", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f47edb4b-85db-4ecc-9eee-12850d1fd2b7")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("f47edb4b-85db-4ecc-9eee-12850d1fd2b7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
