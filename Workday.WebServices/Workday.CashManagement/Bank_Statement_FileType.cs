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
	public class Bank_Statement_FileType : INotifyPropertyChanged
	{
		private Bank_Statement_FileObjectType bank_Statement_File_ReferenceField;

		private Bank_Statement_File_DataType[] bank_Statement_File_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bank_Statement_FileObjectType Bank_Statement_File_Reference
		{
			get
			{
				return this.bank_Statement_File_ReferenceField;
			}
			set
			{
				this.bank_Statement_File_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statement_File_Reference");
			}
		}

		[XmlElement("Bank_Statement_File_Data", Order = 1)]
		public Bank_Statement_File_DataType[] Bank_Statement_File_Data
		{
			get
			{
				return this.bank_Statement_File_DataField;
			}
			set
			{
				this.bank_Statement_File_DataField = value;
				this.RaisePropertyChanged("Bank_Statement_File_Data");
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
