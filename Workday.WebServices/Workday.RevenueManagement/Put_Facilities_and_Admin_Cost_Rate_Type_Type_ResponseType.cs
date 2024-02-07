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
	public class Put_Facilities_and_Admin_Cost_Rate_Type_Type_ResponseType : INotifyPropertyChanged
	{
		private Facilities_and_Admin_Cost_Rate_Type_TypeObjectType facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Facilities_and_Admin_Cost_Rate_Type_TypeObjectType Facilities_and_Admin_Cost_Rate_Type_Type_Reference
		{
			get
			{
				return this.facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Cost_Rate_Type_Type_Reference");
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
