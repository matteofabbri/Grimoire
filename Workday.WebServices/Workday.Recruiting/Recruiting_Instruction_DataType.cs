using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Recruiting_Instruction_DataType : INotifyPropertyChanged
	{
		private Recruiting_InstructionObjectType recruiting_Instruction_ReferenceField;

		private bool do_Not_Send_To_Recruiting_SystemField;

		private bool do_Not_Send_To_Recruiting_SystemFieldSpecified;

		private string nameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Recruiting_InstructionObjectType Recruiting_Instruction_Reference
		{
			get
			{
				return this.recruiting_Instruction_ReferenceField;
			}
			set
			{
				this.recruiting_Instruction_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Instruction_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Do_Not_Send_To_Recruiting_System
		{
			get
			{
				return this.do_Not_Send_To_Recruiting_SystemField;
			}
			set
			{
				this.do_Not_Send_To_Recruiting_SystemField = value;
				this.RaisePropertyChanged("Do_Not_Send_To_Recruiting_System");
			}
		}

		[XmlIgnore]
		public bool Do_Not_Send_To_Recruiting_SystemSpecified
		{
			get
			{
				return this.do_Not_Send_To_Recruiting_SystemFieldSpecified;
			}
			set
			{
				this.do_Not_Send_To_Recruiting_SystemFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_Send_To_Recruiting_SystemSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
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
