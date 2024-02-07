using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_ISIR_Transaction_RequestType : INotifyPropertyChanged
	{
		private ISIR_TransactionObjectType iSIR_Transaction_ReferenceField;

		private ISIR_Transaction_DataType iSIR_Transaction_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ISIR_TransactionObjectType ISIR_Transaction_Reference
		{
			get
			{
				return this.iSIR_Transaction_ReferenceField;
			}
			set
			{
				this.iSIR_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("ISIR_Transaction_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public ISIR_Transaction_DataType ISIR_Transaction_Data
		{
			get
			{
				return this.iSIR_Transaction_DataField;
			}
			set
			{
				this.iSIR_Transaction_DataField = value;
				this.RaisePropertyChanged("ISIR_Transaction_Data");
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
