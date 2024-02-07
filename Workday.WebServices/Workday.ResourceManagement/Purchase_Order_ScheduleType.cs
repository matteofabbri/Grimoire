using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Purchase_Order_ScheduleType : INotifyPropertyChanged
	{
		private Purchase_Order_ScheduleObjectType purchase_Order_Schedule_ReferenceField;

		private Purchase_Order_Schedule_DataType[] purchase_Order_Schedule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_Order_ScheduleObjectType Purchase_Order_Schedule_Reference
		{
			get
			{
				return this.purchase_Order_Schedule_ReferenceField;
			}
			set
			{
				this.purchase_Order_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Schedule_Reference");
			}
		}

		[XmlElement("Purchase_Order_Schedule_Data", Order = 1)]
		public Purchase_Order_Schedule_DataType[] Purchase_Order_Schedule_Data
		{
			get
			{
				return this.purchase_Order_Schedule_DataField;
			}
			set
			{
				this.purchase_Order_Schedule_DataField = value;
				this.RaisePropertyChanged("Purchase_Order_Schedule_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
