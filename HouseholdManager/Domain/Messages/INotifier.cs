﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseholdManager.Domain.Twilio;
using HouseholdManager.Models;
using Twilio;
using Twilio.Clients;
using Twilio.TwiML.Messaging;

namespace HouseholdManager.Domain.Messages
{
    public interface INotifier
    {
        Task SendNotificationAsync(Notification notification);
        Task SendNotificationAsync(Send notification);
    }

    public class Notifier : INotifier
    {
        private readonly ITwilioMessageSender _client;

        public Notifier(TwilioConfiguration configuration) : this(
            new TwilioMessageSender(configuration)
        )
        { }

        public Notifier(ITwilioMessageSender client)
        {
            _client = client;
        }

        public async Task SendNotificationAsync(Notification notification)
        {
            await _client.SendMessageAsync(notification.To, notification.Message);
        }

        public Task SendNotificationAsync(Send notification)
        {
            throw new NotImplementedException();
        }
    }
}
