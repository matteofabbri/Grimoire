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
	public class Salary_Over_The_Cap_TypeType : INotifyPropertyChanged
	{
		private Salary_Over_The_Cap_TypeObjectType salary_Over_The_Cap_Type_Request_ReferenceField;

		private Salary_Over_The_Cap_Type_DataType salary_Over_The_Cap_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Salary_Over_The_Cap_TypeObjectType Salary_Over_The_Cap_Type_Request_Reference
		{
			get
			{
				return this.salary_Over_The_Cap_Type_Request_ReferenceField;
			}
			set
			{
				this.salary_Over_The_Cap_Type_Request_ReferenceField = value;
				this.RaisePropertyChanged("Salary_Over_The_Cap_Type_Request_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Salary_Over_The_Cap_Type_DataType Salary_Over_The_Cap_Type_Data
		{
			get
			{
				return this.salary_Over_The_Cap_Type_DataField;
			}
			set
			{
				this.salary_Over_The_Cap_Type_DataField = value;
				this.RaisePropertyChanged("Salary_Over_The_Cap_Type_Data");
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
