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
	public class Work_Status_Rule_Row_SubdataType : INotifyPropertyChanged
	{
		private Work_Status_Rule_RowObjectType work_Status_Rule_Row_ReferenceField;

		private string orderField;

		private string work_Status_Rule_NameField;

		private Work_StatusObjectType work_Status_ReferenceField;

		private Work_Status_RuleObjectType work_Status_Rule_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Work_Status_Rule_RowObjectType Work_Status_Rule_Row_Reference
		{
			get
			{
				return this.work_Status_Rule_Row_ReferenceField;
			}
			set
			{
				this.work_Status_Rule_Row_ReferenceField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Row_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 2)]
		public string Work_Status_Rule_Name
		{
			get
			{
				return this.work_Status_Rule_NameField;
			}
			set
			{
				this.work_Status_Rule_NameField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Work_StatusObjectType Work_Status_Reference
		{
			get
			{
				return this.work_Status_ReferenceField;
			}
			set
			{
				this.work_Status_ReferenceField = value;
				this.RaisePropertyChanged("Work_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Work_Status_RuleObjectType Work_Status_Rule_Reference
		{
			get
			{
				return this.work_Status_Rule_ReferenceField;
			}
			set
			{
				this.work_Status_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
