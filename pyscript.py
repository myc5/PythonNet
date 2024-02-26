def say_hello():
    return "Hello"

def return_message(message):
    return message
    

def convert():
    time = int(input("Time in seconds: "))
    from math import floor
    hours = floor(time/3600)
    minutes = floor((time-hours*3600)/60)
    seconds = floor(time-hours*3600-minutes*60)
    return print(str(hours)+"h " + str(minutes) + "min " + str(seconds) +"s")