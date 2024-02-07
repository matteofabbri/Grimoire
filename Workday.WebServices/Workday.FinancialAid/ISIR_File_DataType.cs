using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ISIR_File_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string tG_NumberField;

		private DateTime file_Load_DateField;

		private bool file_Load_DateFieldSpecified;

		private ISIR_Transaction_DataType[] iSIR_Transaction_DataField;

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
		public string TG_Number
		{
			get
			{
				return this.tG_NumberField;
			}
			set
			{
				this.tG_NumberField = value;
				this.RaisePropertyChanged("TG_Number");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime File_Load_Date
		{
			get
			{
				return this.file_Load_DateField;
			}
			set
			{
				this.file_Load_DateField = value;
				this.RaisePropertyChanged("File_Load_Date");
			}
		}

		[XmlIgnore]
		public bool File_Load_DateSpecified
		{
			get
			{
				return this.file_Load_DateFieldSpecified;
			}
			set
			{
				this.file_Load_DateFieldSpecified = value;
				this.RaisePropertyChanged("File_Load_DateSpecified");
			}
		}

		[XmlElement("ISIR_Transaction_Data", Order = 3)]
		public ISIR_Transaction_DataType[] ISIR_Transaction_Data
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
