using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contingent_Worker_Personal_Info_UpdateType : INotifyPropertyChanged
	{
		private Contingent_Worker_Reference_DataType contingent_Worker_ReferenceField;

		private Worker_Personal_Info_DataType contingent_Worker_Personal_Info_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contingent_Worker_Reference_DataType Contingent_Worker_Reference
		{
			get
			{
				return this.contingent_Worker_ReferenceField;
			}
			set
			{
				this.contingent_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Contingent_Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Worker_Personal_Info_DataType Contingent_Worker_Personal_Info_Data
		{
			get
			{
				return this.contingent_Worker_Personal_Info_DataField;
			}
			set
			{
				this.contingent_Worker_Personal_Info_DataField = value;
				this.RaisePropertyChanged("Contingent_Worker_Personal_Info_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
