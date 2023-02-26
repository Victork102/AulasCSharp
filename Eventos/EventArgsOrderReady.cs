using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
	class EventArgsOrderReady:EventArgs
	{
		private UInt16 orderNum;

		public UInt16 OrderNum
		{
			get { return orderNum; }
		}

		public EventArgsOrderReady(UInt16 pOrderNum)
		{
			orderNum = pOrderNum;
		}
	}
}
