import socket

client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
client.connect(("localhost", 12345))

name = input("Enter Name: ")
address = input("Enter Address: ")
pps = input("Enter PPS Number: ")
license = input("Enter Driving License: ")

data = f"{name},{address},{pps},{license}"

client.send(data.encode())

reg_number = client.recv(1024).decode()
print("Your Registration Number:", reg_number)

client.close()