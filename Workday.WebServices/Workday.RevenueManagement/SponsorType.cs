using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class SponsorType : INotifyPropertyChanged
	{
		private SponsorObjectType sponsor_ReferenceField;

		private Sponsor_WWS_DataType[] sponsor_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public SponsorObjectType Sponsor_Reference
		{
			get
			{
				return this.sponsor_ReferenceField;
			}
			set
			{
				this.sponsor_ReferenceField = value;
				this.RaisePropertyChanged("Sponsor_Reference");
			}
		}

		[XmlElement("Sponsor_Data", Order = 1)]
		public Sponsor_WWS_DataType[] Sponsor_Data
		{
			get
			{
				return this.sponsor_DataField;
			}
			set
			{
				this.sponsor_DataField = value;
				this.RaisePropertyChanged("Sponsor_Data");
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
