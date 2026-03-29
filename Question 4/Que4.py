import requests

url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

response = requests.get(url)

print(response.text)