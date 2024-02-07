using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proposed_Calculated_Plan_Assignment_Container_DataType : INotifyPropertyChanged
	{
		private Proposed_Calculated_Plan_Assignment_DataType[] calculated_Plan_Sub_DataField;

		private bool replaceField;

		private bool replaceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Calculated_Plan_Sub_Data", Order = 0)]
		public Proposed_Calculated_Plan_Assignment_DataType[] Calculated_Plan_Sub_Data
		{
			get
			{
				return this.calculated_Plan_Sub_DataField;
			}
			set
			{
				this.calculated_Plan_Sub_DataField = value;
				this.RaisePropertyChanged("Calculated_Plan_Sub_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Replace
		{
			get
			{
				return this.replaceField;
			}
			set
			{
				this.replaceField = value;
				this.RaisePropertyChanged("Replace");
			}
		}

		[XmlIgnore]
		public bool ReplaceSpecified
		{
			get
			{
				return this.replaceFieldSpecified;
			}
			set
			{
				this.replaceFieldSpecified = value;
				this.RaisePropertyChanged("ReplaceSpecified");
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
