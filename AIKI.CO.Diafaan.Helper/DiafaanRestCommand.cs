using System;
using System.Collections.Generic;
using System.Text;

namespace AIKI.CO.Diafaan.Helper
{
    public class DiafaanRestCommand
    {
        public static string SendMessage => "send-message";
        public static string RemoveQueuedMessage => "remove-queued-message";
        public static string RequestReceivedMessages => "request-received-messages";
        public static string SendServerCommand => "send-server-command";
        public static string SendServerCommandStartGateway => "start-gateway";
        public static string SendServerCommandStopGateway => "stop-gateway";
        public static string SendServerCommandRestartGateway => "restart-gateway";
        public static string SendServerCommandStartConnector => "start-connector";
        public static string SendServerCommandStopConnector => "stop-connector";
        public static string SendServerCommandRestartConnector => "restart-connector";
        public static string SendServerCommandResetSendLimit => "reset-send-limit";
        public static string SendServerCommandPauseSending => "pause-sending";
        public static string SendServerCommandResumeSending => "resume-sending";
        public static string SendServerCommandGetServerConfiguration => "get-server-configuration";
        public static string SendServerCommandGetServerSettings => "get-server-settings";
        public static string SendServerCommandSetGatewayProperty => "set-gateway-property";
        public static string SendServerCommandSetConnectorProperty => "set-connector-property";
        public static string SendServerCommandSetRoutingProperty => "set-routing-property";
        public static string SendServerCommandGetSetSettingsProperty => "set-settings-property";
        public static string MessageTypeSMSAutomatic => "sms.automatic";
        public static string MessageTypeSMText => "sms.text";
        public static string MessageTypeSMSUniCode => "sms.unicode";
        public static string MessageTypeSMSBinary => "sms.binary";
        public static string MessageTypeSMSPDU => "sms.pdu";
        public static string MessageTypeGSMUSSD => "gsm.ussd";
        public static string MessageTypeFlashMessage => "Flash message";
    }
}
