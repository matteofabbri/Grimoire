using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Cancel_Revenue_Recognition_Schedule_RequestType : INotifyPropertyChanged
	{
		private Revenue_Recognition_ScheduleObjectType revenue_Recognition_Schedule_ReferenceField;

		private bool cancel_All_InstallmentsField;

		private bool cancel_All_InstallmentsFieldSpecified;

		private Revenue_Recognition_InstallmentObjectType[] installments_To_Cancel_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Revenue_Recognition_ScheduleObjectType Revenue_Recognition_Schedule_Reference
		{
			get
			{
				return this.revenue_Recognition_Schedule_ReferenceField;
			}
			set
			{
				this.revenue_Recognition_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Cancel_All_Installments
		{
			get
			{
				return this.cancel_All_InstallmentsField;
			}
			set
			{
				this.cancel_All_InstallmentsField = value;
				this.RaisePropertyChanged("Cancel_All_Installments");
			}
		}

		[XmlIgnore]
		public bool Cancel_All_InstallmentsSpecified
		{
			get
			{
				return this.cancel_All_InstallmentsFieldSpecified;
			}
			set
			{
				this.cancel_All_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Cancel_All_InstallmentsSpecified");
			}
		}

		[XmlElement("Installments_To_Cancel_Reference", Order = 2)]
		public Revenue_Recognition_InstallmentObjectType[] Installments_To_Cancel_Reference
		{
			get
			{
				return this.installments_To_Cancel_ReferenceField;
			}
			set
			{
				this.installments_To_Cancel_ReferenceField = value;
				this.RaisePropertyChanged("Installments_To_Cancel_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
