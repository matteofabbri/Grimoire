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
	public class ProgramType : INotifyPropertyChanged
	{
		private ProgramObjectType program_ReferenceField;

		private Program_DataType[] program_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ProgramObjectType Program_Reference
		{
			get
			{
				return this.program_ReferenceField;
			}
			set
			{
				this.program_ReferenceField = value;
				this.RaisePropertyChanged("Program_Reference");
			}
		}

		[XmlElement("Program_Data", Order = 1)]
		public Program_DataType[] Program_Data
		{
			get
			{
				return this.program_DataField;
			}
			set
			{
				this.program_DataField = value;
				this.RaisePropertyChanged("Program_Data");
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
