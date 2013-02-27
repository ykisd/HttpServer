﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.3634
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HttpServer.Resources {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LogMessage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LogMessage() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HttpServer.Resources.LogMessage", typeof(LogMessage).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   リクエスト受付中... に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AcceptRequest {
            get {
                return ResourceManager.GetString("AcceptRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   終了：「Enter」を押してください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FinishedForError {
            get {
                return ResourceManager.GetString("FinishedForError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   リクエストを取得：【URL】{0} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string GetRequest {
            get {
                return ResourceManager.GetString("GetRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ===== HTTP SERVER START ===== に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string HttpServerStart {
            get {
                return ResourceManager.GetString("HttpServerStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   レスポンスデータの読込終了 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReadResponseDataEnd {
            get {
                return ResourceManager.GetString("ReadResponseDataEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   レスポンスデータの読込開始 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReadResponseDataStart {
            get {
                return ResourceManager.GetString("ReadResponseDataStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   レスポンスを解放 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ResponseClose {
            get {
                return ResourceManager.GetString("ResponseClose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   レスポンスを設定：【PATH】{0} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string SetResponse {
            get {
                return ResourceManager.GetString("SetResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スレッド処理終了 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ThreadProcessEnd {
            get {
                return ResourceManager.GetString("ThreadProcessEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   スレッド処理開始 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ThreadProcessStart {
            get {
                return ResourceManager.GetString("ThreadProcessStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   レスポンスデータの書出終了 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string WriteResponseDataEnd {
            get {
                return ResourceManager.GetString("WriteResponseDataEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   レスポンスデータの書出開始 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string WriteResponseDataStart {
            get {
                return ResourceManager.GetString("WriteResponseDataStart", resourceCulture);
            }
        }
    }
}