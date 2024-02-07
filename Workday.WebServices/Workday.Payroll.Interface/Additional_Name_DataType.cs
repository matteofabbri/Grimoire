using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Additional_Name_DataType : INotifyPropertyChanged
	{
		private Person_Name_Detail_DataType name_Detail_DataField;

		private Additional_Name_TypeObjectType name_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Person_Name_Detail_DataType Name_Detail_Data
		{
			get
			{
				return this.name_Detail_DataField;
			}
			set
			{
				this.name_Detail_DataField = value;
				this.RaisePropertyChanged("Name_Detail_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Additional_Name_TypeObjectType Name_Type_Reference
		{
			get
			{
				return this.name_Type_ReferenceField;
			}
			set
			{
				this.name_Type_ReferenceField = value;
				this.RaisePropertyChanged("Name_Type_Reference");
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
