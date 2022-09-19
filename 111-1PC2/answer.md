# 第2次練習-練習-PC2
>
>學號：109111139 
><br />
>姓名：繆昊廷 
><br />
>作業撰寫時間：30mins
><br />
>最後撰寫文件日期：2022/09/19
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容


下段程式碼則為使用後結果：計算出華氏溫度為119510.6

```csharp
protected void Page_Load(object sender, EventArgs e)
        {
            int i_In = 66377;
            double d_Ou = -999;
            double C = (double)i_In;
            d_Ou = (C*9/5)+ 32;
            Response.Write(d_Ou);
                
        }
```


下段程式碼則為使用後結果：無

```html
<%@ Page Language="C#" AutoEventWireup="true" ...>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" ...>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
```


## 個人認為完成作業須具備觀念

需了解計算時必須是整數和整數計算、浮數點和浮數點計算，需了解如何宣告變數，和如何將變數轉成浮點數。
