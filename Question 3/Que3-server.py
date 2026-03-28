import socket

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind(("localhost", 12345))
server.listen(1)

print("Server is running...")

conn, addr = server.accept()
print("Connected by", addr)

data = conn.recv(1024).decode()
print("Received:", data)

conn.close()