import socket
import sqlite3

conn_db = sqlite3.connect("customers.db")
cursor = conn_db.cursor()

cursor.execute("""CREATE TABLE IF NOT EXISTS customers (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT ,address TEXT ,pps TEXT , license TEXT )""")
                
server = socket.socket(socket.AF_INET,socket.SOCK_STREAM) 
server.bind(("localhost", 12345))
server.listen(1)

print("Server is running...")

conn, addr = server.accept()
print("Connected by", addr)

data = conn.recv(1024).decode()
print("Received:", data)

name, address, pps, license = data.split(",")

cursor.execute("INSERT INTO customers (name, address, pps, license) VALUES (?, ?, ?, ?)", (name, address, pps, license))
conn_db.commit()

print("Data stored in the database!")

conn.close()
conn_db.close()