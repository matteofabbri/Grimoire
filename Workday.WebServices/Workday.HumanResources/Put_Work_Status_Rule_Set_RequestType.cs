using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Work_Status_Rule_Set_RequestType : INotifyPropertyChanged
	{
		private Work_Status_Rule_SetObjectType work_Status_Rule_Set_ReferenceField;

		private Work_Status_Rule_Set_DataType work_Status_Rule_Set_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Work_Status_Rule_SetObjectType Work_Status_Rule_Set_Reference
		{
			get
			{
				return this.work_Status_Rule_Set_ReferenceField;
			}
			set
			{
				this.work_Status_Rule_Set_ReferenceField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Set_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Work_Status_Rule_Set_DataType Work_Status_Rule_Set_Data
		{
			get
			{
				return this.work_Status_Rule_Set_DataField;
			}
			set
			{
				this.work_Status_Rule_Set_DataField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Set_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
