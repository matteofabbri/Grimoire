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
	public class Bank_Statements_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime statement_Date_FromField;

		private bool statement_Date_FromFieldSpecified;

		private DateTime statement_Date_ToField;

		private bool statement_Date_ToFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Statement_Date_From
		{
			get
			{
				return this.statement_Date_FromField;
			}
			set
			{
				this.statement_Date_FromField = value;
				this.RaisePropertyChanged("Statement_Date_From");
			}
		}

		[XmlIgnore]
		public bool Statement_Date_FromSpecified
		{
			get
			{
				return this.statement_Date_FromFieldSpecified;
			}
			set
			{
				this.statement_Date_FromFieldSpecified = value;
				this.RaisePropertyChanged("Statement_Date_FromSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Statement_Date_To
		{
			get
			{
				return this.statement_Date_ToField;
			}
			set
			{
				this.statement_Date_ToField = value;
				this.RaisePropertyChanged("Statement_Date_To");
			}
		}

		[XmlIgnore]
		public bool Statement_Date_ToSpecified
		{
			get
			{
				return this.statement_Date_ToFieldSpecified;
			}
			set
			{
				this.statement_Date_ToFieldSpecified = value;
				this.RaisePropertyChanged("Statement_Date_ToSpecified");
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
