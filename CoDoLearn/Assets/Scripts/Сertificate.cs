using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using System.Text;

public class Сertificate : MonoBehaviour
{

    [SerializeField]
    Texture2D sigtarure;

    public void CreatePdf()
    {
        //BaseFont baseFont = BaseFont.CreateFont(@"C:\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
        string fullName = string.Format("{0} прошел курс по {1}", PlayerPrefsManager.GetFullName(), PlayerPrefsManager.GetCategory());
        Document document = new Document(PageSize.A4, 25, 25, 30, 30);
        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream( "Certifecate"+PlayerPrefsManager.GetCategory()+".pdf", FileMode.OpenOrCreate));
        document.Open();
        string combineStr = Path.Combine(Application.streamingAssetsPath, "ArialRegular.ttf");
        Debug.Log(combineStr);
        BaseFont bf = BaseFont.CreateFont(combineStr, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

        PdfContentByte cb2 = writer.DirectContent;
        cb2.Rectangle(10f, 10f, document.PageSize.Width - 40f, document.PageSize.Height - 40f);
        cb2.SetFontAndSize(bf, 16);
        cb2.BeginText();
        cb2.ShowTextAligned(
        PdfContentByte.ALIGN_CENTER, "Сертификат", 300f, document.PageSize.Height - 50f, 0);

        cb2.EndText();

        PdfContentByte cb = writer.DirectContent;
        cb.Rectangle(10f, 10f, document.PageSize.Width - 20f, document.PageSize.Height - 20f);
        cb.SetFontAndSize(bf, 13);
        cb.BeginText();
        cb.ShowTextAligned(
        PdfContentByte.ALIGN_CENTER, fullName, 300f, document.PageSize.Height - 100f, 0);

        cb.EndText();


        PdfContentByte cb1 = writer.DirectContent;
        cb1.Rectangle(10f, 10f, document.PageSize.Width - 40f, document.PageSize.Height - 40f);
        cb1.SetFontAndSize(bf, 13);
        cb1.BeginText();
        cb1.ShowTextAligned(
        PdfContentByte.ALIGN_LEFT, "Иванов И.И", 350f, document.PageSize.Height - 130f, 0);

        cb1.EndText();

        //byte[] img = sigtarure.EncodeToPNG();
        Image image = Image.GetInstance(Application.streamingAssetsPath + "/sign.jpg");
        image.ScalePercent(24f);
        image.SetAbsolutePosition(document.PageSize.Width - 36f - 120f,
      document.PageSize.Height - 36f - 100.6f);
        document.Add(image);
        document.Close();
    }
}
