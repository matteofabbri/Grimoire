using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Corrected_Or_Rescinded_Transaction_DataType : INotifyPropertyChanged
	{
		private Main_Transaction_Log_Entry_DataType[] main_Transaction_DataField;

		private Transaction_Log_Rescind_And_Correct_Event_DataType[] correction_Or_Rescind_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Main_Transaction_Data", Order = 0)]
		public Main_Transaction_Log_Entry_DataType[] Main_Transaction_Data
		{
			get
			{
				return this.main_Transaction_DataField;
			}
			set
			{
				this.main_Transaction_DataField = value;
				this.RaisePropertyChanged("Main_Transaction_Data");
			}
		}

		[XmlElement("Correction_Or_Rescind_Data", Order = 1)]
		public Transaction_Log_Rescind_And_Correct_Event_DataType[] Correction_Or_Rescind_Data
		{
			get
			{
				return this.correction_Or_Rescind_DataField;
			}
			set
			{
				this.correction_Or_Rescind_DataField = value;
				this.RaisePropertyChanged("Correction_Or_Rescind_Data");
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
