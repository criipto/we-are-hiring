namespace ``Work at Criipto``

module ``Team players`` =
    type Language = | ``F#``
    type Developer = | ``Quality focused codesmith`` of Language
    type Operator = | ``You build it, you run it``
    type ErrorHandler = | ``Bugs are production line stops``
    type CodeContributor = | Employee of Developer * Operator * ErrorHandler    

module ``Production system`` =
    type InspectionParadigm = | ``Build quality in``
    type TestingPreference = | Automated
    type ResilienceMode = | ``Safe to fail``
    type GuardRails = | ``Poka yoke``
    type QualityControl = | Humane of InspectionParadigm * TestingPreference * ResilienceMode * GuardRails

    type Flow = | SinglePiece
    type Workflow = | Kanban of Flow
    type DeliveryMode = | Continuous 
    type ManufacturingProcess = | ``Lean and agile`` of QualityControl * Workflow * DeliveryMode

    type SchedulingParadigm = | ``Queueing theory for Markovian processess``
    type Bottleneck = | ``Mental bandwith``
    type SoftwareWork = | ``Human knowledge work`` of SchedulingParadigm * Bottleneck
    type ManagementParadigm = | ``Make The Work work`` of SoftwareWork

    type Adversaries =
        | ``Identity theft``
        | Fraud
        | Trolling
        | ``Surveillance capitalism``
    type Means = | ``Pick a fight with`` of Adversaries list
    type Purpose =
        | ``Make people sovereign online as well as offline`` of Means
    type Company = | SoftwareFactory of Purpose * ManagementParadigm * ManufacturingProcess

module Criipto =
    open ``Production system``

    let purpose =
        ``Make people sovereign online as well as offline`` (
            ``Pick a fight with`` [
                ``Identity theft``
                Fraud
                Trolling
                ``Surveillance capitalism``
            ]
        )
    let humaneManagement =
        ``Make The Work work`` (
            ``Human knowledge work`` (
                ``Queueing theory for Markovian processess``, ``Mental bandwith``
            )
        )
    let highQuality =
        Humane (
            ``Build quality in``, Automated, ``Safe to fail``, ``Poka yoke``
        )
    let singlePieceFlow = SinglePiece |> Kanban
    let continuousDelivery = Continuous
    let steadyCadence = highQuality, singlePieceFlow, continuousDelivery
    let leanManufacturing = ``Lean and agile`` steadyCadence
    let criipto = SoftwareFactory (purpose, humaneManagement, leanManufacturing)

module ``Job applications`` =
    type ContactInfo = | Email of string | GitHubHandle of string
    type Person = { Name : string; ContactInfo : ContactInfo }
    type Resume = string

module ``Apply to position`` =
    open ``Team players``
    open ``Production system``
    open Criipto
    open ``Job applications``

    let ``DevOps person on core services team, position 1`` =
        Employee (
            ``Quality focused codesmith`` ``F#``,
            ``You build it, you run it``,
            ``Bugs are production line stops``
        )
    let ``DevOps person on core services team, position 2`` =
        ``DevOps person on core services team, position 1``
    let currentlyOpenPositions = [
        ``DevOps person on core services team, position 1``
        ``DevOps person on core services team, position 2``
    ]

    type ApplyAt (company : Company) =
        member __.Send
            (you : Person, position : CodeContributor, resume : Resume) =
                // TODO: PR's accepted. Or drop us an email on jobs@criipto.com.
                ()

    let you = { Name = "..."; ContactInfo = GitHubHandle "..." }
    let desiredPosition = ``DevOps person on core services team, position 1``
    let resume = "What you think we should now about you"
    let yourApplication = ApplyAt criipto
    yourApplication.Send (you, desiredPosition, resume)

