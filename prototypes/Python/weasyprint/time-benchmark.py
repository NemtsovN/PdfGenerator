import timeit

from weasyprint_prototype import pdf_convert

# Define the number of iterations for the benchmark
iterations = 10

# Measure execution time using timeit
execution_time = timeit.timeit(pdf_convert, number=iterations)

# Calculate mean time
mean_time = execution_time / iterations

# Print the result
print(f"Mean Time: {mean_time:.6f} seconds")
