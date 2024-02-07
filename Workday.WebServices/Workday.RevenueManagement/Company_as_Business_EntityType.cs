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
	public class Company_as_Business_EntityType : INotifyPropertyChanged
	{
		private Company_as_Business_EntityObjectType company_as_Business_Entity_ReferenceField;

		private Company_as_Business_Entity_DataType[] company_as_Business_Entity_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Company_as_Business_EntityObjectType Company_as_Business_Entity_Reference
		{
			get
			{
				return this.company_as_Business_Entity_ReferenceField;
			}
			set
			{
				this.company_as_Business_Entity_ReferenceField = value;
				this.RaisePropertyChanged("Company_as_Business_Entity_Reference");
			}
		}

		[XmlElement("Company_as_Business_Entity_Data", Order = 1)]
		public Company_as_Business_Entity_DataType[] Company_as_Business_Entity_Data
		{
			get
			{
				return this.company_as_Business_Entity_DataField;
			}
			set
			{
				this.company_as_Business_Entity_DataField = value;
				this.RaisePropertyChanged("Company_as_Business_Entity_Data");
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
