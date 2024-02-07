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
	public class ISIR_Transaction_Request_CriteriaType : INotifyPropertyChanged
	{
		private Financial_Aid_Award_YearObjectType financial_Aid_Award_Year_ReferenceField;

		private ISIR_Transaction_StatusObjectType transaction_Status_ReferenceField;

		private Financial_Aid_School_CodeObjectType federal_School_Code_ReferenceField;

		private ISIR_FileObjectType iSIR_File_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Financial_Aid_Award_YearObjectType Financial_Aid_Award_Year_Reference
		{
			get
			{
				return this.financial_Aid_Award_Year_ReferenceField;
			}
			set
			{
				this.financial_Aid_Award_Year_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Aid_Award_Year_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public ISIR_Transaction_StatusObjectType Transaction_Status_Reference
		{
			get
			{
				return this.transaction_Status_ReferenceField;
			}
			set
			{
				this.transaction_Status_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Status_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Financial_Aid_School_CodeObjectType Federal_School_Code_Reference
		{
			get
			{
				return this.federal_School_Code_ReferenceField;
			}
			set
			{
				this.federal_School_Code_ReferenceField = value;
				this.RaisePropertyChanged("Federal_School_Code_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public ISIR_FileObjectType ISIR_File_Reference
		{
			get
			{
				return this.iSIR_File_ReferenceField;
			}
			set
			{
				this.iSIR_File_ReferenceField = value;
				this.RaisePropertyChanged("ISIR_File_Reference");
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
