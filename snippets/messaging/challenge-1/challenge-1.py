# Download the Python helper library from twilio.com/docs/python/install
from twilio.rest import Client

# Your Account Sid and Auth Token from twilio.com/user/account
account_sid = ""
auth_token = "your_auth_token"
client = Client(account_sid, auth_token)

numbers = client.available_phone_numbers("US") \
                .local \
                .list(area_code="510")

# Purchase the phone number
number = client.incoming_phone_numbers \
               .create(phone_number=numbers[0].phone_number)

print(number.sid)
