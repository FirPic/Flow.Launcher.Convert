using System;
using GroupDocs.Conversion;

namespace Converter {
  public class TextConvert {

    public List < string > textExtensionFUle = new List < string > () {
      "txt",
      "docx",
      "pdf",
      "odt"
    };

  }
  public class TXT {
    public void txt_docx(string source, string output) {

    }
    public void txt_pdf(string source, string output) {

    }
    public void txt_odt(string source, string output) {
      // Load source file TXT for conversion
      var converter = new Conversion.Converter("input.txt");
      // Prepare conversion options for target format ODT
      var convertOptions = converter.GetPossibleConversions()["odt"].ConvertOptions;
      // Convert to ODT format
      converter.Convert("output.odt", convertOptions);
    }
  }
  public class DOCX {
    public void docx_txt(string source, string output) {

    }
    public void docx_pdf(string source, string output) {

    }
    public void docx_odt(string source, string output) {

    }
  }
  public class PDF {
    public void pdf_txt(string source, string output) {

    }
    public void pdf_docx(string source, string output) {

    }
    public void pdf_odt(string source, string output) {

    }
  }
  public class ODT {
    public void odt_txt(string source, string output) {

    }
    public void odt_docx(string source, string output) {

    }
    public void odt_pdf(string source, string output) {

    }
  }
}