using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_Plan_DetailsType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType business_Plan_Details_ReferenceField;

		private Business_Plan_Details_DataType[] business_Plan_Details_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Business_Plan_Details_Reference
		{
			get
			{
				return this.business_Plan_Details_ReferenceField;
			}
			set
			{
				this.business_Plan_Details_ReferenceField = value;
				this.RaisePropertyChanged("Business_Plan_Details_Reference");
			}
		}

		[XmlElement("Business_Plan_Details_Data", Order = 1)]
		public Business_Plan_Details_DataType[] Business_Plan_Details_Data
		{
			get
			{
				return this.business_Plan_Details_DataField;
			}
			set
			{
				this.business_Plan_Details_DataField = value;
				this.RaisePropertyChanged("Business_Plan_Details_Data");
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
