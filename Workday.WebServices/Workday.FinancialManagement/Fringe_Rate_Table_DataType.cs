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
	public class Fringe_Rate_Table_DataType : INotifyPropertyChanged
	{
		private string fringe_Rate_Table_IDField;

		private string fringe_Rate_Table_NameField;

		private Fringe_Rate_DataType[] fringe_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Fringe_Rate_Table_ID
		{
			get
			{
				return this.fringe_Rate_Table_IDField;
			}
			set
			{
				this.fringe_Rate_Table_IDField = value;
				this.RaisePropertyChanged("Fringe_Rate_Table_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Fringe_Rate_Table_Name
		{
			get
			{
				return this.fringe_Rate_Table_NameField;
			}
			set
			{
				this.fringe_Rate_Table_NameField = value;
				this.RaisePropertyChanged("Fringe_Rate_Table_Name");
			}
		}

		[XmlElement("Fringe_Rate_Data", Order = 2)]
		public Fringe_Rate_DataType[] Fringe_Rate_Data
		{
			get
			{
				return this.fringe_Rate_DataField;
			}
			set
			{
				this.fringe_Rate_DataField = value;
				this.RaisePropertyChanged("Fringe_Rate_Data");
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
