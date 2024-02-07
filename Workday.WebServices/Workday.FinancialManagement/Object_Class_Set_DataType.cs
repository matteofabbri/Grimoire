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
	public class Object_Class_Set_DataType : INotifyPropertyChanged
	{
		private string object_Class_Set_IDField;

		private string object_Class_Set_NameField;

		private Object_Class_DataType[] object_Class_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Object_Class_Set_ID
		{
			get
			{
				return this.object_Class_Set_IDField;
			}
			set
			{
				this.object_Class_Set_IDField = value;
				this.RaisePropertyChanged("Object_Class_Set_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Object_Class_Set_Name
		{
			get
			{
				return this.object_Class_Set_NameField;
			}
			set
			{
				this.object_Class_Set_NameField = value;
				this.RaisePropertyChanged("Object_Class_Set_Name");
			}
		}

		[XmlElement("Object_Class_Data", Order = 2)]
		public Object_Class_DataType[] Object_Class_Data
		{
			get
			{
				return this.object_Class_DataField;
			}
			set
			{
				this.object_Class_DataField = value;
				this.RaisePropertyChanged("Object_Class_Data");
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
