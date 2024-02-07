using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Add_Retiree_Status_Sub_Process_DetailsType : INotifyPropertyChanged
	{
		private DateTime retirement_DateField;

		private Event_Classification_SubcategoryObjectType retirement_Reason_ReferenceField;

		private Retiree_OrganizationObjectType retiree_Organization_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Retirement_Date
		{
			get
			{
				return this.retirement_DateField;
			}
			set
			{
				this.retirement_DateField = value;
				this.RaisePropertyChanged("Retirement_Date");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Retirement_Reason_Reference
		{
			get
			{
				return this.retirement_Reason_ReferenceField;
			}
			set
			{
				this.retirement_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Retirement_Reason_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Retiree_OrganizationObjectType Retiree_Organization_Reference
		{
			get
			{
				return this.retiree_Organization_ReferenceField;
			}
			set
			{
				this.retiree_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Retiree_Organization_Reference");
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
