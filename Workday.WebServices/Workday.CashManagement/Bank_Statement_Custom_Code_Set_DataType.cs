using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Bank_Statement_Custom_Code_Set_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private Bank_Statement_FormatObjectType bank_Statement_Format_ReferenceField;

		private string descriptionField;

		private string commentField;

		private Bank_Statement_Balance_Type_DataType[] bank_Statement_Balance_Type_DataField;

		private Bank_Statement_Transaction_Type_DataType[] bank_Statement_Transaction_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public Bank_Statement_FormatObjectType Bank_Statement_Format_Reference
		{
			get
			{
				return this.bank_Statement_Format_ReferenceField;
			}
			set
			{
				this.bank_Statement_Format_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statement_Format_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 4)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		[XmlElement("Bank_Statement_Balance_Type_Data", Order = 5)]
		public Bank_Statement_Balance_Type_DataType[] Bank_Statement_Balance_Type_Data
		{
			get
			{
				return this.bank_Statement_Balance_Type_DataField;
			}
			set
			{
				this.bank_Statement_Balance_Type_DataField = value;
				this.RaisePropertyChanged("Bank_Statement_Balance_Type_Data");
			}
		}

		[XmlElement("Bank_Statement_Transaction_Type_Data", Order = 6)]
		public Bank_Statement_Transaction_Type_DataType[] Bank_Statement_Transaction_Type_Data
		{
			get
			{
				return this.bank_Statement_Transaction_Type_DataField;
			}
			set
			{
				this.bank_Statement_Transaction_Type_DataField = value;
				this.RaisePropertyChanged("Bank_Statement_Transaction_Type_Data");
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
