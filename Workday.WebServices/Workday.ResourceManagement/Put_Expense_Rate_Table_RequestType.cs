using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Expense_Rate_Table_RequestType : INotifyPropertyChanged
	{
		private Expense_Rate_TableObjectType expense_Rate_Table_ReferenceField;

		private Expense_Rate_Table_DataType expense_Rate_Table_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Expense_Rate_TableObjectType Expense_Rate_Table_Reference
		{
			get
			{
				return this.expense_Rate_Table_ReferenceField;
			}
			set
			{
				this.expense_Rate_Table_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Expense_Rate_Table_DataType Expense_Rate_Table_Data
		{
			get
			{
				return this.expense_Rate_Table_DataField;
			}
			set
			{
				this.expense_Rate_Table_DataField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Data");
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
