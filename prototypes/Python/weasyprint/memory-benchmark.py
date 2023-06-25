from weasyprint_prototype import pdf_convert
from memory_profiler import profile

@profile
def memory_benchmark():
    pdf_convert()

memory_benchmark()