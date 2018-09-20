using System;
using Twilio;
using Twilio.Rest.Proxy.V1.Service.Session.Participant;

const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
const string authToken = "your_auth_token";

TwilioClient.Init(accountSid, authToken);

var messageInteraction = MessageInteractionResource.Create(
    body: "Body",
    pathServiceSid: "KSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
    pathSessionSid: "KCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
    pathParticipantSid: "KPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
);

Console.WriteLine(messageInteraction.Sid);
