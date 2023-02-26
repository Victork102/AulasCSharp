using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
	class Kitchen
	{
		public delegate void OrderReadyMessageEventHandler(object source, EventArgsOrderReady e);
		public event OrderReadyMessageEventHandler OrderReadyMessageEvent;
		public void SendOrderReradyMessage(UInt16 pOrderNum)
		{
			if (OrderReadyMessageEvent != null)
			{
				EventArgsOrderReady e = new EventArgsOrderReady(pOrderNum);
				OrderReadyMessageEvent(this, e);
			}
		}
	}
}
