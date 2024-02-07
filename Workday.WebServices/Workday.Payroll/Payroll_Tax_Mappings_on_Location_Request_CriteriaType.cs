using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Tax_Mappings_on_Location_Request_CriteriaType : INotifyPropertyChanged
	{
		private LocationObjectType[] location_ReferenceField;

		private DateTime effective_Date_ReferenceField;

		private bool effective_Date_ReferenceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Location_Reference", Order = 0)]
		public LocationObjectType[] Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date_Reference
		{
			get
			{
				return this.effective_Date_ReferenceField;
			}
			set
			{
				this.effective_Date_ReferenceField = value;
				this.RaisePropertyChanged("Effective_Date_Reference");
			}
		}

		[XmlIgnore]
		public bool Effective_Date_ReferenceSpecified
		{
			get
			{
				return this.effective_Date_ReferenceFieldSpecified;
			}
			set
			{
				this.effective_Date_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Effective_Date_ReferenceSpecified");
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
