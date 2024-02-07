using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_Organization_Get_DataType : INotifyPropertyChanged
	{
		private OrganizationObjectType organization_ReferenceField;

		private Headcount_Plan_Line_Get_DataType[] headcount_Plan_Line_Get_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OrganizationObjectType Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("Headcount_Plan_Line_Get_Data", Order = 1)]
		public Headcount_Plan_Line_Get_DataType[] Headcount_Plan_Line_Get_Data
		{
			get
			{
				return this.headcount_Plan_Line_Get_DataField;
			}
			set
			{
				this.headcount_Plan_Line_Get_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Line_Get_Data");
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
