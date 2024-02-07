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
	public class Transcript_Order_Request_ReferencesType : INotifyPropertyChanged
	{
		private Transcript_OrderObjectType[] transcript_Order_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Transcript_Order_Reference", Order = 0)]
		public Transcript_OrderObjectType[] Transcript_Order_Reference
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
