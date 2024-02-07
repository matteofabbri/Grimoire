using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Transcript_OrderType : INotifyPropertyChanged
	{
		private Transcript_OrderObjectType transcript_Order_ReferenceField;

		private Transcript_Order_DataType transcript_Order_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Transcript_OrderObjectType Transcript_Order_Reference
		{
			get
			{
				return this.transcript_Order_ReferenceField;
			}
			set
			{
				this.transcript_Order_ReferenceField = value;
				this.RaisePropertyChanged("Transcript_Order_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Transcript_Order_DataType Transcript_Order_Data
		{
			get
			{
				return this.transcript_Order_DataField;
			}
			set
			{
				this.transcript_Order_DataField = value;
				this.RaisePropertyChanged("Transcript_Order_Data");
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
