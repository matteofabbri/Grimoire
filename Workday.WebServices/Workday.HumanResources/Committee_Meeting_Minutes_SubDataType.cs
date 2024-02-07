using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Committee_Meeting_Minutes_SubDataType : INotifyPropertyChanged
	{
		private Committee_Meeting_MinutesObjectType minutes_ReferenceField;

		private string detailsField;

		private string committee_Meeting_Minutes_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_Meeting_MinutesObjectType Minutes_Reference
		{
			get
			{
				return this.minutes_ReferenceField;
			}
			set
			{
				this.minutes_ReferenceField = value;
				this.RaisePropertyChanged("Minutes_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Details
		{
			get
			{
				return this.detailsField;
			}
			set
			{
				this.detailsField = value;
				this.RaisePropertyChanged("Details");
			}
		}

		[XmlElement(Order = 2)]
		public string Committee_Meeting_Minutes_ID
		{
			get
			{
				return this.committee_Meeting_Minutes_IDField;
			}
			set
			{
				this.committee_Meeting_Minutes_IDField = value;
				this.RaisePropertyChanged("Committee_Meeting_Minutes_ID");
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
