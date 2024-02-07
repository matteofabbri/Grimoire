using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Stock_Participation_Rate_Table_RequestType : INotifyPropertyChanged
	{
		private Stock_Participation_Rate_TableObjectType stock_Participation_Rate_Table_ReferenceField;

		private Stock_Participation_Rate_Table_Request_DataType stock_Participation_Rate_Table_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Stock_Participation_Rate_TableObjectType Stock_Participation_Rate_Table_Reference
		{
			get
			{
				return this.stock_Participation_Rate_Table_ReferenceField;
			}
			set
			{
				this.stock_Participation_Rate_Table_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Participation_Rate_Table_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Stock_Participation_Rate_Table_Request_DataType Stock_Participation_Rate_Table_Data
		{
			get
			{
				return this.stock_Participation_Rate_Table_DataField;
			}
			set
			{
				this.stock_Participation_Rate_Table_DataField = value;
				this.RaisePropertyChanged("Stock_Participation_Rate_Table_Data");
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
