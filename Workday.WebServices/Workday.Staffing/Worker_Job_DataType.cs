using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Job_DataType : INotifyPropertyChanged
	{
		private Position_Detail_DataType position_DataField;

		private Position_Organization_DataType position_Organizations_DataField;

		private Position_Management_Chains_DataType position_Management_Chains_DataField;

		private bool primary_JobField;

		private bool primary_JobFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Position_Detail_DataType Position_Data
		{
			get
			{
				return this.position_DataField;
			}
			set
			{
				this.position_DataField = value;
				this.RaisePropertyChanged("Position_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Position_Organization_DataType Position_Organizations_Data
		{
			get
			{
				return this.position_Organizations_DataField;
			}
			set
			{
				this.position_Organizations_DataField = value;
				this.RaisePropertyChanged("Position_Organizations_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Position_Management_Chains_DataType Position_Management_Chains_Data
		{
			get
			{
				return this.position_Management_Chains_DataField;
			}
			set
			{
				this.position_Management_Chains_DataField = value;
				this.RaisePropertyChanged("Position_Management_Chains_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Primary_Job
		{
			get
			{
				return this.primary_JobField;
			}
			set
			{
				this.primary_JobField = value;
				this.RaisePropertyChanged("Primary_Job");
			}
		}

		[XmlIgnore]
		public bool Primary_JobSpecified
		{
			get
			{
				return this.primary_JobFieldSpecified;
			}
			set
			{
				this.primary_JobFieldSpecified = value;
				this.RaisePropertyChanged("Primary_JobSpecified");
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
