from weasyprint import HTML, CSS
from weasyprint.text.fonts import FontConfiguration

def pdf_convert(): 
    with open('./Stubs/index.html', 'r', encoding='utf-8') as file:
        html_input = file.read()

    with open('./Stubs/styles.css', 'r', encoding='utf-8') as file:
        css_input = file.read()

    font_config = FontConfiguration()
    html = HTML(string=html_input)
    css = CSS(string=css_input)

    html.write_pdf(
        './Results/output.pdf', stylesheets=[css],
        font_config=font_config)
