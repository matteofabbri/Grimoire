using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Budget_Fringe_Rate_TableType : INotifyPropertyChanged
	{
		private Budget_Fringe_Rate_TableObjectType fringe_Rate_Table_ReferenceField;

		private Fringe_Rate_Table_DataType[] fringe_Rate_Table_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Budget_Fringe_Rate_TableObjectType Fringe_Rate_Table_Reference
		{
			get
			{
				return this.fringe_Rate_Table_ReferenceField;
			}
			set
			{
				this.fringe_Rate_Table_ReferenceField = value;
				this.RaisePropertyChanged("Fringe_Rate_Table_Reference");
			}
		}

		[XmlElement("Fringe_Rate_Table_Data", Order = 1)]
		public Fringe_Rate_Table_DataType[] Fringe_Rate_Table_Data
		{
			get
			{
				return this.fringe_Rate_Table_DataField;
			}
			set
			{
				this.fringe_Rate_Table_DataField = value;
				this.RaisePropertyChanged("Fringe_Rate_Table_Data");
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
